using System;

namespace Project_GAME_GK_HK3_2026_ERROR.Logic
{
    public enum GameStatus
    {
        Playing, // van dang choi binh thuong
        Check,   // vua dang bi chieu nhung van con duong thoat ...
        Checkmate, // vua dang bi chieu va khong con duong thoat
        Stalemate, // hoa co 

        Surrender, // dau hang
    }
    public static class GameRules
    {
        // Kiem tra vua co dang bi chieu ko
        public static bool IsInCheck(Piece[,] board, PieceColor color)
        {
            // tim vua
            int kingRow = -1, kingCol = -1;
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    Piece piece = board[r, c];
                    if (piece != null && piece.Type == PieceType.King && piece.Color == color)
                    {
                        kingRow = r;
                        kingCol = c;
                        break;
                    }
                }
            }
            if (kingRow == -1) return false; // khong tim thay vua ? , errror
            // kiem tra tat ca quan doi phuong co the an vua khong
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    Piece piece = board[r, c];
                    if (piece != null && piece.Color != color)
                    {
                        if (MoveRules.IsValidMove(board, r, c, kingRow, kingCol))
                        {
                            return true; // vua dang bi chieu
                        }
                    }
                }
            }
            return false; // vua khong bi chieu
        }

        // kiem tra con vua bi chieu ko ,
        // vi du di chuyen con  xe, thi con vua co bi chieu ko
        public static bool LeavesKingInCheck(Piece[,] board, int fromRow, int fromCol, int toRow, int toCol)
        {
            Piece movingPiece = board[fromRow, fromCol];
            Piece targetPiece = board[toRow, toCol];
            // Thực hiện di chuyển tạm thời
            board[toRow, toCol] = movingPiece;
            board[fromRow, fromCol] = null;
            bool isInCheck = IsInCheck(board, movingPiece.Color);
            // Hoàn tác di chuyển
            board[fromRow, fromCol] = movingPiece;
            board[toRow, toCol] = targetPiece;
            return isInCheck;
        }

        // Kiem tra nuoc di hop le , vua nhap thanh , vua bi chieu , nuoc di hop le
        public static bool IsLegalMove(Piece[,] board, int fromRow, int fromCol, int toRow, int toCol)
        {

            Piece piece = board[fromRow, fromCol];
            if (piece == null) return false;

            // nhap thanh , function rieng , king di chuyen 2 o
            if (piece.Type == PieceType.King && fromRow == toRow && Math.Abs(toCol - fromCol) == 2)
            {

                return CanCastle(board, fromRow, fromCol, toCol);
            }


            // nuoc di thuong
            if (!MoveRules.IsValidMove(board, fromRow, fromCol, toRow, toCol))
                return false;

            return !LeavesKingInCheck(board, fromRow, fromCol, toRow, toCol);
        }

        public static bool CanCastle(Piece[,] board, int fromRow, int fromCol, int toCol)
        {
            //MessageBox.Show("CanCastle: " + fromRow + ", " + fromCol + ", " + toCol);
            Piece king = board[fromRow, fromCol];
            if (king == null || king.Type != PieceType.King || king.HasMoved)
                return false;
            //check vua di chuyen ch
            int homeRow = (king.Color == PieceColor.White) ? 7 : 0;
            if (fromRow != homeRow || fromCol != 4 || king.HasMoved)
            {

                return false; // vua phai o cot e
            }
            //check xe di chuyen ch
            int dir = (toCol - fromCol) > 0 ? 1 : -1; // huong di chuyen cua vua, 1 la phai
            int rookCol = ((dir == 1) ? 7 : 0); // cot cua xe
            Piece rook = board[homeRow, rookCol];
            if (rook == null || rook.Type != PieceType.Rook || rook.HasMoved)
            {

                return false; // xe phai o cot a hoac h va chua di chuyen
            }

            // o giua vua xe phai trong
            for (int c = fromCol + dir; c != rookCol; c += dir)
            {

                if (board[homeRow, c] != null)
                {

                    return false; // o giua vua va xe phai trong
                }
            }

            // vua ko dc nhap thanh khi bi chieu
            if (IsInCheck(board, king.Color)) return false;
            if (LeavesKingInCheck(board, fromRow, fromCol, fromRow, fromCol + dir)) return false;
            if (LeavesKingInCheck(board, fromRow, fromCol, fromRow, fromCol + 2 * dir)) return false;

            return true;

        }

        // kiem tra xem co con nuoc di nao hop le
        public static bool HasAnyLegalMoves(Piece[,] board, PieceColor color)
        {
            for (int fromRow = 0; fromRow < 8; fromRow++)
            {
                for (int fromCol = 0; fromCol < 8; fromCol++)
                {
                    Piece piece = board[fromRow, fromCol];
                    if (piece != null && piece.Color == color)
                    {
                        for (int toRow = 0; toRow < 8; toRow++)
                        {
                            for (int toCol = 0; toCol < 8; toCol++)
                            {
                                if (IsLegalMove(board, fromRow, fromCol, toRow, toCol))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }

        public static GameStatus GetStatus(Piece[,] board, PieceColor sideToMove)
        {
            bool inCheck = IsInCheck(board, sideToMove);
            // xem vua co dnag bi chieu ko
            bool hasMove = HasAnyLegalMoves(board, sideToMove);
            //xem doi phuong con nuoc di hop le ko
            if (!hasMove && inCheck) return GameStatus.Checkmate;
            if (!hasMove && !inCheck) return GameStatus.Stalemate;
            if (hasMove && inCheck) return GameStatus.Check;
            return GameStatus.Playing;
        }
    }
}

