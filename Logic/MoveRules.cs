using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_GAME_GK_HK3_2026_ERROR
{
    public static class MoveRules
    {
        public static bool IsValidMove(Piece[,] board, int fromRow, int fromCol, int toRow, int toCol)
        {
            Piece piece = board[fromRow, fromCol];
            if (piece == null) return false;
            // kiem tra co quan co nao khong
            if (fromRow == toRow && fromCol == toCol) return false;
            // kiem tra trung nhau

            Piece targetPiece = board[toRow, toCol];
            //check quan o dich
            if (targetPiece != null && targetPiece.Color == piece.Color) // cung phe thi khong an
                return false;
            // chay luat di chuyen tung quan
            switch (piece.Type)
            {
                case PieceType.Pawn:
                    return IsValidPawnMove(board, piece, fromRow, fromCol, toRow, toCol);
                case PieceType.Rook:
                    return IsValidRookMove(board, piece, fromRow, fromCol, toRow, toCol);
                case PieceType.Knight:
                    return IsValidKnightMove(board, piece, fromRow, fromCol, toRow, toCol);
                case PieceType.Bishop:
                    return IsValidBishopMove(board, piece, fromRow, fromCol, toRow, toCol);
                case PieceType.Queen:
                    return IsValidQueenMove(board, piece, fromRow, fromCol, toRow, toCol);
                case PieceType.King:
                    return IsValidKingMove(board, piece, fromRow, fromCol, toRow, toCol);
                default:
                    return false;
            }
        }

        private static bool IsValidKingMove(Piece[,] board, Piece piece, int fromRow, int fromCol, int toRow, int toCol)
        {
            int[] dX = new int[8] { 1, 1, 0, -1, -1, -1, 0, 1 };
            int[] dY = new int[8] { 0, 1, 1, 1, 0, -1, -1, -1 };
            for (int i = 0; i < 8; i++)
            {
                int newRow = fromRow + dX[i];
                int newCol = fromCol + dY[i];
                if (newRow == toRow && newCol == toCol)
                    return true;
            }
            return false;
        }

        private static bool IsValidQueenMove(Piece[,] board, Piece piece, int fromRow, int fromCol, int toRow, int toCol)
        {
            int[] dX = new int[8] { 1, 1, -1, -1, 0, 0, 1, -1 };
            int[] dY = new int[8] { 1, -1, 1, -1, 1, -1, 0, 0 };
            for (int i = 0; i < 8; i++)
            {
                int newRow = fromRow + dX[i];
                int newCol = fromCol + dY[i];
                while (newRow >= 0 && newRow < 8 && newCol >= 0 && newCol < 8)
                {
                    if (newRow == toRow && newCol == toCol)
                        return true;
                    if (board[newRow, newCol] != null)
                        break; // có quân chắn đường
                    newRow += dX[i];
                    newCol += dY[i];
                }
            }
            return false;
        }

        private static bool IsValidBishopMove(Piece[,] board, Piece piece, int fromRow, int fromCol, int toRow, int toCol)
        {
            int[] dX = new int[4] { 1, 1, -1, -1 };
            int[] dY = new int[4] { 1, -1, 1, -1 };
            for (int i = 0; i < 4; i++)
            {
                int newRow = fromRow + dX[i];
                int newCol = fromCol + dY[i];
                while (newRow >= 0 && newRow < 8 && newCol >= 0 && newCol < 8)
                {
                    if (newRow == toRow && newCol == toCol)
                        return true;
                    if (board[newRow, newCol] != null)
                        break; // có quân chắn đường
                    newRow += dX[i];
                    newCol += dY[i];
                }
            }
            return false;
        }

        private static bool IsValidKnightMove(Piece[,] board, Piece piece, int fromRow, int fromCol, int toRow, int toCol)
        {
            int[] dX = new int[8] { 2, 1, -1, -2, -2, -1, 1, 2 };
            int[] dY = new int[8] { 1, 2, 2, 1, -1, -2, -2, -1 };
            for (int i = 0; i < 8; i++)
            {
                int newRow = fromRow + dX[i];
                int newCol = fromCol + dY[i];
                if (newRow == toRow && newCol == toCol)
                    return true;
            }
            return false;
        }

        private static bool IsValidRookMove(Piece[,] board, Piece piece, int fromRow, int fromCol, int toRow, int toCol)
        {
            int[] dX = new int[4] { 1, -1, 0, 0 };
            int[] dY = new int[4] { 0, 0, 1, -1 };
            for (int i = 0; i < 4; i++)
            {
                int newRow = fromRow + dX[i];
                int newCol = fromCol + dY[i];
                while (newRow >= 0 && newRow < 8 && newCol >= 0 && newCol < 8)
                {
                    if (newRow == toRow && newCol == toCol)
                        return true;
                    if (board[newRow, newCol] != null)
                        break; // có quân chắn đường
                    newRow += dX[i];
                    newCol += dY[i];
                }
            }


            return false;
        }


        // luat di chuyen con tot
        private static bool IsValidPawnMove(Piece[,] board, Piece pawn, int fromRow, int fromCol, int toRow, int toCol)
        {
            int dir = pawn.Color == PieceColor.White ? -1 : 1; 
            // xem con tot trang hay den de xet huong di chuyen
            int startRow = pawn.Color == PieceColor.White ? 6 : 1;
            // xet tot trang hay den de xet hang xuat phat cua tot

            int dRow = toRow - fromRow; // tot di dc bn hang, duong len am xuong
            int dCol = toCol - fromCol; // tot di dc bn cot, duong sang trai am sang phai
            Piece target = board[toRow, toCol]; // thu nam o o dich

            //ddi thang 1 o
            if (dCol == 0 && dRow == dir && target == null) return true;
            // di thang 2 o xuat phat
            if (dCol == 0 && dRow == 2 * dir && fromRow == startRow
                && target == null && board[fromRow + dir, fromCol] == null)
                return true;
            //an cheo
            if (Math.Abs(dCol) == 1 && dRow == dir && target != null && target.Color != pawn.Color)
                return true;
            //ăn qua đường
            
            return false;
        }
    }
}
