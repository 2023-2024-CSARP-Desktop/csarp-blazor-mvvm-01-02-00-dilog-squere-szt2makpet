namespace SquareProject.Models
{
    public class Square
    {
        private double _side;
        private double _bside;
        private int v;

        public double Side
        {
            get => _side;
            set
            {
                if (value <= 0)
                    throw new SqueraSideCannotBeNagativOrZero(value + " méretre a téglalap oldalát nem lehet változtatni. A négyzet oldala maradt " + _side + ".");
                else
                    _side = value;
            }
        }

        public Square(double side, double bside)
        {
            if (side <= 0)
                throw new SqueraSideCannotBeNagativOrZero(side + " oldalú téglalap nincs. A négyzetet nem jön létre.");
            else
                _side = side;

            if (bside <= 0)
                throw new SqueraSideCannotBeNagativOrZero(side + " oldalú téglalap nincs. A négyzetet nem jön létre.");
            else
                _bside = bside;
        }

        public Square(int v)
        {
            this.v = v;
        }

        public double Perimeter
        {
            get => 2* (_bside + _side);
        }

        public double Area
        {
            get => _bside * _side;
        }

        public override string ToString()
        {
            return $"{Side} méter a téglalap oldala.\nKerülete {Area}.\nTerülete {Area}.";
        }

    }
}
