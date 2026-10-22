namespace Project_GAME_GK_HK3_2026_ERROR
{
    public enum PieceType
    {
        Pawn,
        Rook,
        Knight,
        Bishop,
        Queen,
        King
    }
    public enum PieceColor
    {
        White,
        Black
    }

    public class Piece
    {
        public PieceType Type { get; set; }
        public PieceColor Color { get; set; }

        public bool HasMoved { get; set; }
        public Piece(PieceType type, PieceColor color)
        {
            Type = type;
            Color = color;
            HasMoved = false;
        }

    }
}
