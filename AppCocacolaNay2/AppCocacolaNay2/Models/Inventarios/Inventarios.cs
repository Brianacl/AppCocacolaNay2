using System;
using SQLite;

namespace AppCocacolaNay2.Models.Inventarios
{
    public class zt_cat_cedis
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string IdCEDI { get; set; }
        public string CEDI { get; set; }

        public override string ToString()
        {
            return string.Format("[zt_cat_cedis: IdCEDI={0}, CEDI={1}]",
                                 "Id={2}",
                                   IdCEDI, CEDI, Id);
        }
    }


    //Tabla SAP: ZMM006F Catalogo de Almacenes Cocacola.
    //[Table("zt_cat_almacenes")]
    public class zt_cat_almacenes
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string IdCEDI { get; set; }
        public string IdAlmacen { get; set; }
        public string Almacen { get; set; }

        public override string ToString()
        {
            return string.Format("[zt_cat_almacenes: IdCEDI={0}, IdAlmacen={1}, Almacen={2}]",
                                 "Id={3}",
                                   IdCEDI, IdAlmacen, Almacen, Id);
        }

    }


    //Tabla SAP: ZMM004F Catalogo de Productos Cocacola.
    //[Table("zt_cat_productos")]
    public class zt_cat_productos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string SKU { get; set; }
        public string CodigoBarras { get; set; }
        public string Material { get; set; }

        public override string ToString()
        {
            return string.Format("[zt_cat_productos: SKU={0}, CodigoBarras={1}, Material={2}]",
                                 "Id={3}",
                                   SKU, CodigoBarras, Material, Id);
        }

    }


    //Tabla SAP: ZMM007F Catalogo de Unidades de Medida.
    //[Table("zt_cat_unidad_medidas")]
    public class zt_cat_unidad_medidas
    {
        [PrimaryKey, AutoIncrement]
        public Int64 Id { get; set; }
        public string IdUMedida { get; set; }
        public string UMedida { get; set; }

        public override string ToString()
        {
            return string.Format("[zt_cat_unidad_medidas: IdUMedida={0}, UMedida={1}]",
                                 "Id={2}",
                                   IdUMedida, UMedida, Id);
        }

    }



    //Tabla SAP: ZMM001F Encabezado del Inventario
    //[Table("zt_inventarios")]
    public class zt_inventarios
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string IdInventario { get; set; }
        public string IdCEDI { get; set; }
        public string CEDI { get; set; }
        //public DateTime FechaReg { get; set; }
        //public DateTime Hora { get; set; }   
        public string FechaReg { get; set; }
        public string Hora { get; set; }
        public string Usuario { get; set; }

        public override string ToString()
        {
            return string.Format("[zt_inventarios: IdInventario={0}, IdCEDI={1}, CEDI={2}," +
                                 " FechaReg={3}, Hora={4}, Usuario={5}]",
                                 " Id={6}",
                                   IdInventario, IdCEDI, CEDI, FechaReg, Hora, Usuario, Id);
        }
    }



    //Tabla SAP: ZMM002F Detalle del Inventario
    //[Table("zt_inventarios_det")]
    public class zt_inventarios_det
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string IdInventario { get; set; }
        //[PrimaryKey]
        public string SKU { get; set; }
        public string Material { get; set; }
        public float CantTeorica { get; set; }
        public float CantFisica { get; set; }
        public float Diferencia { get; set; }
        public string UMedida { get; set; }

        public override string ToString()
        {
            return string.Format("[zt_inventarios_det: IdInventario={0}, SKU={1}, Material={2}," +
                                 " CantTeorica={3}, CantFisica={4}, Diferencia={5}, UMedida={6}]",
                                 " Id={7}",
                                   IdInventario, SKU, Material, CantTeorica, CantFisica, Diferencia, UMedida, Id);
        }
    }



    //Tabla SAP: ZMM003F Detalle de los conteos y ubicaciones en almacen.
    //[Table("zt_inventarios_conteos")]
    public class zt_inventarios_conteos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string IdInventario { get; set; }
        //[PrimaryKey]
        public string SKU { get; set; }
        //[PrimaryKey]
        public int IdConteo { get; set; }
        //[PrimaryKey]
        public string IdUbicacion { get; set; }
        public string IdCEDI { get; set; }
        public string IdAlmacen { get; set; }
        public string Almacen { get; set; }
        public string Lote { get; set; }
        public string CodBarras { get; set; }
        public string Material { get; set; }
        public float CantFisica { get; set; }
        public string IdUMedida { get; set; }
        public float CantPZA { get; set; }
        //public DateTime FechaReg { get; set; }
        //public DateTime HoraReg { get; set; }
        //public DateTime FechaUltMod { get; set; }
        //public DateTime HoraUltMod { get; set; }
        public String FechaReg { get; set; }
        public String HoraReg { get; set; }
        public String FechaUltMod { get; set; }
        public String HoraUltMod { get; set; }
        public string Usuario { get; set; }

        public override string ToString()
        {
            return string.Format("[zt_inventarios_conteos:  IdInventario={0}, SKU={1}, IdConteo={2}," +
                                 " IdUbicacion={3}, IdCEDI={4}, IdAlmacen={5}, Almacen={6}," +
                                 " Lote={7}, CodBarras={8}, CantFisica={9}, UMedida={10}, CantPZA={11}," +
                                 " FechaReg={12}, HoraReg={13}, FechaUltMod={14}, HoraUltMod={15}, Usuario={16}]",
                                 " Id={17}",
                                   IdInventario, SKU, IdConteo, IdUbicacion, IdCEDI, IdAlmacen, Almacen, Lote,
                                   CodBarras, CantFisica, IdUMedida, CantPZA, FechaReg, HoraReg, FechaUltMod, HoraUltMod, Usuario, Id);
        }
    }
}
