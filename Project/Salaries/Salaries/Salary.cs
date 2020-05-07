﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaries
{
    class Salary
    {
        private bool bonus_bool;
        public double brutto;
        private double base_sal;
        private double bonus;
        private double seniority = 0; //wysługa
        private double netto;

        public void calc_brutto(int years)
        {
            if(years > 4)
            {
                if (years > 20)
                    seniority = base_sal * 0.2;
                else
                    seniority = base_sal * years * 0.01;
            }

            if (bonus_bool)
                brutto = base_sal + bonus + seniority;
            else
                brutto = base_sal + seniority;
        }

        public void calc_netto()
        {
            //uzupełnić po wypełnieniu wszystkich calc
        }
    }
}