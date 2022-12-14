using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UD5T2.MVVM.Models;

namespace UD5T2.MVVM.ViewModels
{
    public class BMIViewModel
    {
        /// <summary>
        /// Declaramos la propiedad BMI
        /// </summary>
        public BMI BMI {
            get;
            set;
        
        }
        public BMIViewModel() {
            //Llamamos al constructor de BMI
            this.BMI = new BMI();
            this.BMI.Altura = 25;
            this.BMI.Peso = 50;
        }


        
    }
}
