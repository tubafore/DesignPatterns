using System;

namespace Exercise
{
    public class SpreadSheet
    {
        private static int MAX_ROWS = 3;
        private static int MAX_COLS = 3;

        private readonly StyleManager styleManager;

        private Cell[,] cells = new Cell[MAX_ROWS,MAX_COLS];

        public SpreadSheet()
        {
            styleManager = new StyleManager(new Style { FontFamily = "Times New Roman", FontSize = 12,
                                                        Bold = false });
            GenerateCells();
        }

        public void SetContent(int row, int col, string content)
        {
            EnsureCellExists(row, col);

            cells[row,col].Content = content;
        }

        public void SetFontFamily(int row, int col, string fontFamily)
        {
            EnsureCellExists(row, col);
            Style style = cells[row, col].Style.ShallowCopy();
            style.FontFamily = fontFamily;

            if (styleManager.Contains(style))
            {
                style = styleManager[style.GetHashCode()];
            }
            else
            {
                styleManager[style.GetHashCode()] = style;
            }
            cells[row,col].Style = style;
        }

        private void EnsureCellExists(int row, int col)
        {
            if (row < 0 || row >= MAX_ROWS)
                throw new ArgumentException();

            if (col < 0 || col >= MAX_COLS)
                throw new ArgumentException();
        }

        private void GenerateCells()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                {
                    var cell = new Cell(row, col);
                    cell.Style = styleManager.DefaultStyle;
                    cells[row,col] = cell;
                }
        }

        public void Render()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                    cells[row,col].Render();
        }
    }
}
