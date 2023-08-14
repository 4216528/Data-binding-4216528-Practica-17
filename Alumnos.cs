
// Se agregan las referencias necesarias para el funcionamiento del programa //

using System.ComponentModel;

namespace Data_binding

{

    // Creamos una clase publica para notificar el cambio de valores //
    public class Alumnos : INotifyPropertyChanged

    {


        public event PropertyChangedEventHandler PropertyChanged;

        // Creamos una variable y le asignamos condiciones //

        string nombre = string.Empty;

        public string Nombre

        {

            get => nombre;

            set

            {

                if (nombre == value)return;

                nombre = value;

                OnPropertyChanged(nameof(Nombre));

                OnPropertyChanged(nameof(MostrarNombre));

            }

        }


        // Creamos una clase publica que nos permite imprimir el texto ingresado //
        public string MostrarNombre => $"Nombre ingresado:{Nombre}";

        // Creamos una variable de tipo void y le asignamos propiedades //
        void OnPropertyChanged(string nombre)

        {

            // Creamos una instancia de la clase y imprimimos su resultado //

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));

        }
    }

}
