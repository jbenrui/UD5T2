using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD5T2.MVVM.Models
{
    /// <summary>
    /// Clase BMI
    /// </summary>
    /// <remarks>
    /// En esta clase se define el modelo BMI junto a sus propiedades. Estas propiedades son
    /// Altura, Peso y Resultado
    /// 
    /// El resultado nos devuelve el Indice de masa corponal
    /// Segun el indice cadena devolvera un mensaje o otro
    /// </remarks>

    [AddINotifyPropertyChangedInterface]
    public class BMI
    {
        /// <summary>
        /// Propiedad Altura
        /// </summary>
        public float Altura
        {
            get;
            set;
        }
        /// <summary>
        ///Propiedad Peso
        /// </summary>
        public float Peso
        {
            get;
            set;
        }
        /// <summary>
        /// Propiedad Resultado
        /// </summary>
        public float Resultado
        {
            get
            {
                return (Peso / (float)Math.Pow((Altura), 2) * 10000);

            }
        }

        /// <summary>
        /// Popiedad ResultadoBMI
        /// </summary>
        public string ResultadoBMI
        {
            get
            {
                // Declaramos la variable cadena
                string cadena;

                //Segun el restultado, la cadena nos proporcionara un distinto mensaje
                if (Resultado <= 16) { cadena = "BMI: Delgado Severo"; }
                else if (Resultado <= 17) { cadena = "BMI: Delgado Moderado"; }
                else if (Resultado <= 18.5) { cadena = "BMI: Delgado Medio"; }
                else if (Resultado <= 25) { cadena = "BMI: Normal"; }
                else if (Resultado <= 30) { cadena = "BMI: Sobrepeso"; }
                else if (Resultado <= 35) { cadena = "BMI: Obesidad Clase I"; }
                else if (Resultado <= 40) { cadena = "BMI: Obesidad Clase II"; }
                else { cadena = "BMI: Obesidad Clase III"; }

                // Devolvemos la cadena
                return cadena;
            }
        }

        public BMI() { }
    }
}
