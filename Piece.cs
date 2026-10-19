using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_GAME_GK_HK3_2026_ERROR
{
    public enum PieceType
    {
        None,
        Pawn,
        Rook,
        Knight,
        Bishop,
        Queen,
        King
    }
    public enum PieceColor
    {
        None,
        White,
        Black
    }

    public class Piece
    {
        public PieceType Type { get; set; }
        public PieceColor Color { get; set; }

        public bool HasMoved { get; set; } = false;
        public Piece(PieceType type, PieceColor color)
        {
            Type = type;
            Color = color;
        }
        
    }
}
