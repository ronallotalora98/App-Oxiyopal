import { EntityBase } from './Base/EntityBase';
import { Ciudad } from './Ciudad';
import { Ubicacion } from './Ubicacion';
import { Factura } from './Factura';

export interface Cliente extends EntityBase<number> {

    nombre: string;
    apellido: string;
    documento: string;
    telefono: string;
    direccion: string;
    descripcion: string;

    esEmpresa: boolean;

    ciudadId: number;
    ciudad: Ciudad;
    ubicaciones: Ubicacion[];
    facturas: Factura[];
}

