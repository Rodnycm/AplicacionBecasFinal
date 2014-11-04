using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Curso : IEntity
    {

        private int _idProducto;
        public int Id
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        //<summary> Métodos set y get de la variable nombre</summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param > variable de tipo String que almacena el  nombre del curso</param>
        //<returns> Retorna una variable String con el nombre del curso.</returns> 
        public String nombre { get; set; }



        //<summary> Métodos set y get de la variable codigo</summary>
        //<author>  Valeria Ramírez Cordero </author> 
        //<param > variable de tipo String que almacena el código del curso</param>
        //<returns> Retorna una variable String con el codigo del curso.</returns> 
        public String codigo { get; set; }


        //<summary> Métodos set y get de la variable cuatrimestre</summary>
        //<author>  Valeria Ramírez Cordero </author> 
        //<param > variable de tipo String que almacena el cuatrimestre</param>
        //<returns> Retorna una variable String con el el cuatrimestre en el que se encuentra el curso.</returns> 
        public String cuatrimestre { get; set; }


        //<summary> Métodos set y get de la variable creditos</summary>
        //<author>  Valeria Ramírez Cordero </author> 
        //<param > variable de tipo int que almacena los creditos del curso</param>
        //<returns> Retorna una variable int con los creditos del curso.</returns> 
        public int creditos { get; set; }

        //<summary> Métodos set y get de la variable precio</summary>
        //<author>  Valeria Ramírez Cordero </author> 
        //<param > variable de tipo double que almacena el precio del curso</param>
        //<returns> Retorna una variable double con el precio del curso.</returns> 
        public double precio { get; set; }




        //<summary> Constructor de la clase Curso</summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param > No recibe parámetros</param>
        //<returns> No retorna valor.</returns> 
        public Curso()
        {
            nombre = "";
            codigo = "";
            cuatrimestre = "";
            creditos = 0;
            precio = 0;
        }



        //<summary> Constructor de la clase Curso</summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param name = "pnombre"> variable de tipo String que almacena el  nombre del curso  </param>
        //<param name= "pcodigo" > variable de tipo String que almacena el código del curso </param>
        //<param name = "pcuatrimestre"> variable de tipo String que almacena el cuatrimestre en el que se encuentra el curso </param>
        //<param name = " pcreditos"> variable de tipo int que almacena los créditos del curso</param>
        //<param name = "pprecio"> variable de tipo double que almacena el precio del curso</param>
        //<returns> No retorna valor.</returns> 
        public Curso(String pnombre, String pcodigo, String pcuatrimestre, int pcreditos, double pprecio)
        {
            Id = 0;
            nombre = pnombre;
            codigo = pcodigo;
            cuatrimestre = pcuatrimestre;
            creditos = pcreditos;
            precio = pprecio;
        }




        //<summary> Constructor de la clase Curso</summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param name = "pnombre"> variable de tipo String que almacena el  nombre del curso  </param>
        //<param name= "pcodigo" > variable de tipo String que almacena el código del curso </param>
        //<param name = "pcuatrimestre"> variable de tipo String que almacena el cuatrimestre en el que se encuentra el curso </param>
        //<param name = " pcreditos"> variable de tipo int que almacena los créditos del curso</param>
        //<returns> No retorna valor.</returns> 
        public Curso(String pnombre, String pcodigo, String pcuatrimestre, int pcreditos)
        {
            Id = 0;
            nombre = pnombre;
            codigo = pcodigo;
            cuatrimestre = pcuatrimestre;
            creditos = pcreditos;
        }



        //        public bool IsValid{ 

        //            get { return (GetRuleViolations().Count() == 0); }
        //        }

        //        public IEnumerable<RuleViolation> GetRuleViolations()
        //        {
        //            if (String.IsNullOrEmpty(Nombre))
        //            {
        //                yield return new RuleViolation("precio");
        //            }
        //            if (precio <= 0)

        //                yield return new RuleViolation("El precio debe tener un valor", "Precio");
        //            }

        //            yield break;
        //        }


        //        public IEnumerable<RuleViolation> GetRuleViolations()
        //        {
        //            throw new NotImplementedException();
        //}
        //}


    }
}




