using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{

    enum BreadType
    {
        Single,
        Double
    }

    class BreadFactory
    {
        private double _water;
        private double _flour;
        private double _salt;

        #region Reporting properties

        private int _singleBreadCount;
        public int SingleBreadCount => _singleBreadCount;

        private int _doubleBreadCount;
        public int DoubleBreadCount => _doubleBreadCount;

        private double _income;
        public double Income => _income;

        #endregion

        #region Constructors
        public BreadFactory()
        {
            _water = 10;
            _flour = 40;
            _salt = 2000;
        }

        public BreadFactory(double water, double flour, double salt)
        {
            _water = water;
            _flour = flour;
            _salt = salt;
        }
        #endregion

        #region Add Methods
        public void AddWater(double litr)
        {
            _water += litr;
        }

        public void AddFlour(double kg)
        {
            _flour += kg;
        }

        public void AddSalt(double gr)
        {
            _salt += gr;
        }

        #endregion

        #region Cook methods

        // count = 1 type = single
        public void Cook()
        {
            this.Cook(BreadType.Single, 1);
        }

        // type, count = 1
        public void Cook(BreadType type)
        {
            this.Cook(type, 1);
        }

        // count , type = single
        public void Cook(int count)
        {
            this.Cook(BreadType.Single, count);
        }

        // type, count
        public void Cook(BreadType type, int count)
        {
            double neededWater = type == BreadType.Single ? count * 0.5 : count * 0.8;
            double neededFlour = type == BreadType.Single ? count * 0.25 : count * 0.45;
            double neededSalt = type == BreadType.Single ? count * 20 : count * 35;

            if (_water < neededWater || _flour < neededFlour || _salt < neededSalt)
            {
                Console.WriteLine("ind yoxdur");
                return;
            }

            _water -= neededWater;
            _flour -= neededFlour;
            _salt -= neededSalt;

            _income += type == BreadType.Single ? count * 0.3 : count * 0.5;

            if (type == BreadType.Single)
            {
                _singleBreadCount += count;
            }
            else
            {
                _doubleBreadCount += count;

            }
        }
        #endregion
    }
}
