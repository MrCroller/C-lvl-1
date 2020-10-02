namespace _1_TASK
{
    class Complex
     {
            public double im;
            public double re;

            public Complex()
        {
            im = 0;
            re = 0;
        }

            public Complex(double re, double _im)
        {
            this.re = re;
            im = _im;
        }

            public Complex Minus(Complex x2)
            {
            Complex x3 = new Complex();
                x3.im = im + x2.im;
                x3.re = re - x2.re;
                return x3;
            }
            public Complex Multi(Complex x)
            {
            Complex y = new Complex();
                y.re = re * x.im - im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }

            public double Im 
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value; //пример ограничение положительными числами.
            }
        }
            public override string ToString()
            {
                return re + "+" + im + "i";
            }
        }
}
