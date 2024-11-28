using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banner
{
    public class UBanner : Banner, IBannerOperations
    {
        public UBanner() : base() { }
        public UBanner(int row, int col) : base(row, col) { }
        public void Clear()
        {
            for (int row = 0; row < this.RowNum; row++)
            {
                for (int col = 0; col < this.ColNum; col++)
                {
                    this[row, col] = Color.Black;
                }
            }
        }

        public void DrawLine(int rowI, Color drawingColor)
        {
            if (rowI > this.RowNum || rowI < this.RowNum)
            {
                throw new IndexOutOfRangeException("Nem lehet a mátrixon kivűlről rajzolni.");
            }
            else
            {
                for (int col = 0; col < this.ColNum; col++)
                {
                    this[rowI, col] = drawingColor;
                }
            }
        }

        public void RotateToLeft()
        {
            for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
            {
                Color temp = this[rowIndex, 0];
                for (int columnIndex = 1; columnIndex < ColNum; columnIndex++)
                {
                    this[rowIndex, columnIndex - 1] = this[rowIndex, columnIndex];
                }
                this[rowIndex, ColNum - 1] = temp;
            }
        }

        public void RotateToRight()
        {
            for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
            {
                Color temp = this[rowIndex, ColNum - 1];
                for (int columnIndex = ColNum - 1; columnIndex > 0; columnIndex--)
                {
                    this[rowIndex, columnIndex] = this[rowIndex, columnIndex - 1];
                }
                this[rowIndex, 0] = temp;
            }
        }

        public void ShiftToLeft(Color fillColor)
        {
            for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
            {
                for (int columnIndex = 1; columnIndex < ColNum; columnIndex++)
                {
                    this[rowIndex, columnIndex - 1] = this[rowIndex, columnIndex];
                }
                this[rowIndex, ColNum - 1] = fillColor;
            }
        }

        public void ShiftToRight(Color fillColor)
        {
            for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
            {
                for (int columnIndex = ColNum - 1; columnIndex > 0; columnIndex--)
                {
                    this[rowIndex, columnIndex] = this[rowIndex, columnIndex - 1];
                }
                this[rowIndex, 0] = fillColor;
            }
        }
    }
}
