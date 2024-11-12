using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.vm
{
    public class MainPageVM : INotifyPropertyChanged
    {
        private string nombre = "";
        private string apellidos = "";

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                if (value != nombre)
                {
                    nombre = value;
                    OnPropertyChanged();
                    try
                    {
                        if (!string.IsNullOrEmpty(value) && value.EndsWith("n", StringComparison.OrdinalIgnoreCase))
                        {
                            Apellidos = string.Empty;
                        }
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Error");
                    }
                }
            }
        }

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                if (value != apellidos)
                {
                    try
                    {
                        apellidos = value;
                        OnPropertyChanged();
                        if (!string.IsNullOrEmpty(value) && value.EndsWith("n", StringComparison.OrdinalIgnoreCase))
                        {
                            Nombre = string.Empty;
                        }
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Error");
                    }
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

