using E_9.Entidades;
using E_9.Entidades.Comun;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace E_9.BLL
{
    public class Negocio
    {
        public Resultado ValidarCampo(Props camp)
        {
            Resultado resultado = new Resultado();

            //DNI
            if (string.IsNullOrWhiteSpace(camp.DNI))
            {
                resultado.Errores.Add(
                    new Error
                    {
                        Campo = "DNI",
                        Mensaje = "El DNI es obligatorio."
                    });
            }
            else if (camp.DNI.Length != 8 || !camp.DNI.All(char.IsDigit))
            {
                resultado.Errores.Add(
                   new Error
                   {
                       Campo = "DNI",
                       Mensaje = "El DNI debe tener exactamente 8 caracteres numericos."
                   });
            }

            //Apellido
            if (string.IsNullOrWhiteSpace(camp.Apellido))
            {
                resultado.Errores.Add(
                    new Error
                    {
                        Campo = "Apellido",
                        Mensaje = "El apellido es obligatorio."
                    });
            }

            //Nombre
            if (string.IsNullOrWhiteSpace(camp.Nombre))
            {
                resultado.Errores.Add(
                    new Error
                    {
                        Campo = "Nombre",
                        Mensaje = "El nombre es obligatorio."
                    });
            }

            if (string.IsNullOrWhiteSpace(camp.Edad.ToString()) || camp.Edad < 17 || !camp.Edad.ToString().All(char.IsDigit))
            {
                resultado.Errores.Add(
                    new Error
                    {
                        Campo = "Edad",
                        Mensaje = "La edad es obligatoria y debe ser mayor a 16 años"
                    });
            }

            //Telefono
            if (string.IsNullOrWhiteSpace(camp.Telefono))
            {
                resultado.Errores.Add(
                    new Error
                    {
                        Campo = "Telefono",
                        Mensaje = "El telefono es obligatorio."
                    });

            }
            else if (camp.Telefono.Length < 10 || !camp.Telefono.All(char.IsDigit))
            {
                resultado.Errores.Add(
                   new Error
                   {
                       Campo = "Telefono",
                       Mensaje = "El telefono debe tener como minimo entre 10 y 15 caracteres numericos."
                   });


            }

            //MAIL
            if (string.IsNullOrWhiteSpace(camp.Mail))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Mail",
                    Mensaje = "El campo Mail es obligatorio."
                });
            }
            else
            {
                bool emailValido = Regex.IsMatch(
                    camp.Mail,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$"
                );

                if (!emailValido)
                {
                    resultado.Errores.Add(new Error
                    {
                        Campo = "Mail",
                        Mensaje = "El campo Mail no tiene un formato válido."
                    });
                }
            }

            return resultado;
        }

        public Resultado ValidarCampoModi(Props camp)
        {
            Resultado resultado = new Resultado();

            //Telefono
            if (string.IsNullOrWhiteSpace(camp.Telefono))
            {
                resultado.Errores.Add(
                    new Error
                    {
                        Campo = "Telefono",
                        Mensaje = "El telefono es obligatorio."
                    });

            }
            else if (camp.Telefono.Length < 10 || !camp.Telefono.All(char.IsDigit))
            {
                resultado.Errores.Add(
                   new Error
                   {
                       Campo = "Telefono",
                       Mensaje = "El telefono debe tener como minimo entre 10 y 15 caracteres numericos."
                   });


            }

            //MAIL
            if (string.IsNullOrWhiteSpace(camp.Mail))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Mail",
                    Mensaje = "El campo Mail es obligatorio."
                });
            }
            else
            {
                bool emailValido = Regex.IsMatch(
                    camp.Mail,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$"
                );

                if (!emailValido)
                {
                    resultado.Errores.Add(new Error
                    {
                        Campo = "Mail",
                        Mensaje = "El campo Mail no tiene un formato válido."
                    });
                }
            }

            return resultado;
        }
    }
}