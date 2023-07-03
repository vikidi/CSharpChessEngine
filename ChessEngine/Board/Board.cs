namespace ChessEngine
{
  public class Board 
  {
    /*
    ushort Empty = 0;

    ushort WhitePawn = 1;
    ushort WhiteKnight = 2;
    ushort WhiteBishop = 3;
    ushort WhiteRook = 4;
    ushort WhiteQueen = 5;
    ushort WhiteKing = 6;

    ushort BlackPawn = 9;
    ushort BlackKnight = 10;
    ushort BlackBishop = 11;
    ushort BlackRook = 12;
    ushort BlackQueen = 13;
    ushort BlackKing = 14;
    */

    Dictionary<int, string> Characters = new Dictionary<int, string>() {
      {0, "-"},
      {1, "P"},
      {2, "K"},
      {3, "B"},
      {4, "R"},
      {5, "Q"},
      {6, "X"},
      {9, "p"},
      {10, "k"},
      {11, "b"},
      {12, "r"},
      {13, "q"},
      {14, "x"}
    };

    ushort[] Position { get; set; }
    public Board() 
    {
      Position = new ushort[64] {
        4, 2, 3, 5, 6, 3, 2, 4,
        1, 1, 1, 1, 1, 1, 1, 1,
        0, 0, 0, 0, 0, 0, 0, 0,
        0, 0, 0, 0, 0, 0, 0, 0,
        0, 0, 0, 0, 0, 0, 0, 0,
        0, 0, 0, 0, 0, 0, 0, 0,
        9, 9, 9, 9, 9, 9, 9, 9,
        12, 10, 11, 13, 14, 11, 10, 12
      };
    }

    public void Draw() 
    {
      Console.WriteLine("");

      for (int i = 7; i >= 0; i--) 
      {
        Console.Write(i + 1);
        Console.Write(" | ");

        for (int j = 0; j < 8; j++) 
        {
          ushort piece = Position[i * 8 + j];
          Console.Write(Characters[piece]);
          Console.Write(" ");
        }

        Console.WriteLine();
      }

      Console.WriteLine("    ---------------");
      Console.WriteLine("    A B C D E F G H");
      Console.WriteLine("");
    }
  }
}