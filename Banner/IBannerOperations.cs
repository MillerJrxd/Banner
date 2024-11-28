using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banner
{
    public interface IBannerOperations
    {
        /// <summary>
        /// Feketére színezi a teljes kijelzőt.
        /// </summary>
        public void Clear();
        
        /// <summary>
        /// Egy pixellel balra forgatja a képet.
        /// </summary>
        public void RotateToLeft();

        /// <summary>
        /// Egy pixellel jobbra forgatja a képet.
        /// </summary>
        public void RotateToRight();

        /// <summary>
        /// Balra eltolja az egész mátrixot.
        /// </summary>
        /// <param name="fillColor">Szín</param>
        public void ShiftToLeft(Color fillColor);

        /// <summary>
        /// Jobbra eltolja az egész mátrixot.
        /// </summary>
        /// <param name="fillColor">Szín</param>
        public void ShiftToRight(Color fillColor);

        /// <summary>
        /// Rajzol egy vonalat a megadott színnel.
        /// </summary>
        /// <param name="rowI">A sornak az indexe ahova rajzolja a vonalat.</param>
        /// <param name="drawingColor">A szín amivel rajzolja a vonalat.</param>
        public void DrawLine(int rowI, Color drawingColor);
    }
}
