using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.Constants
{
    public class Messages
    {
        public static class Success
        {
            // Creación
            public const string BrandCreated = "Marca agregada exitosamente";
            public const string CategoryCreated = "Categoría agregada exitosamente.";
            public const string ProductCreated = "Producto agregado exitosamente.";

            // Actualización
            public const string ProductUpdated = "Producto actualizado exitosamente";
            public const string BrandUpdated = "Marca actualizada exitosamente";
            public const string CategoryUpdated = "Categoría actualizada exitosamente";

            // Eliminación
            public const string ProductDeleted = "Producto eliminado exitosamente";
            public const string BrandDeleted = "Marca eliminada exitosamente";
            public const string CategoryDeleted = "Categoría eliminada exitosamente";
        }

        public static class Error
        {
            // Búsqueda/Existencia
            public const string ProductNotFoundWithId = "Producto con ID {0} no encontrado";
            public const string MedicamentoNotFoundWithId = "Medicamento con ID no encontrado";
            public const string InventarioNotFoundWithId = "Inventario con ID no encontrado";
            public const string PacienteNotFoundWithId = "Paciente con ID no encontrado";
            public const string CentroMedicoNotFoundWithId = "Centro Medico con ID no encontrado";
            public const string ContactoPacienteNotFoundWithId = "Cantacto de paciente con ID no encontrado";
            public const string CentroMedicoNotFound = "Cemtrp Médico no encontrado";
            public const string MedicamentoNotFound = "Medicamentos no encontrados";
            public const string InventariosNotFound = "Inventarios no encontrados";
            public const string PacienteNotFound = "Pacientes no encontrados";
            public const string BrandNotFound = "Marca no encontrada";
            public const string CategoryNotFound = "Categoría no encontrada";

            // Creación
            public const string ProductCreateError = "Hubo un error al agregar el producto";
            public const string MedicamentoCreateError = "Hubo un error al agregar el medicamento";
            public const string InventarioCreateError = "Hubo un error al agregar el inventario";
            public const string PcienteCreateError = "Hubo un error al agregar el paciente";
            public const string CentroMedicoCreateError = "Hubo un error al agregar el Centro Médico";
            public const string ContactoPacienteCreateError = "Hubo un error al agregar el contacto del paciente";

            // Actualización
            public const string ProductUpdateError = "Error al actualizar el producto";
            public const string MedicamentoUpdateError = "Error al actualizar el medicamento";
            public const string InventarioUpdateError = "Error al actualizar el inventario";
            public const string PacienteUpdateError = "Error al actualizar el paciente";
            public const string BrandUpdateError = "Error al actualizar la marca";
            public const string CategoryUpdateError = "Error al actualizar la categoría";
            public const string CentroMedicoUpdateError = "Hubo un error al modificar el Centro Médico";
            public const string ContactoPacienteUpdateError = "Hubo un error al modificar el contacto del paciente";

            // Eliminación
            public const string ProductDeleteError = "Error al eliminar el producto";
            public const string MedicamentoDeleteError = "Error al eliminar el medicamento";
            public const string InventarioDeleteError = "Error al eliminar el inventario";
            public const string PacienteDeleteError = "Error al eliminar el paciente";
            public const string BrandDeleteError = "Error al eliminar la marca";
            public const string CategoryDeleteError = "Error al eliminar la categoría";
            public const string ProductCannotBeDeleted = "No se puede eliminar el producto porque tiene referencias";
            public const string EspecialidadError = "Se genero un error al actualizar la especialidad";
            public const string CentroMedicoDeleteError = "Error al eliminar el Centro Médico";
            public const string ContactoPacienteDeleteError = "Error al eliminar el contacto del paciente";
        }

        public static class Validation
        {
            public const string UnSupportedFileType = "El tipo de archivo no es soportado.";
        }

        public static class Info
        {

        }

    }
}
