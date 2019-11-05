import { HistorialCilindro } from './ViewModels/HistorialCilindro';
import { EntityBase } from './Base/EntityBase';
import { TipoDeProducto } from './TipoDeProducto';
import { Estado } from './Estado';
import { HistorialDeFactura } from './ViewModels/HistorialDeFactura';

export interface Cilindro extends EntityBase<number> {
    serial: string;
    tamaño: number;
    fechaDeTraslado: Date | string;

    tipoDeProductoId: number;
    tipoDeProducto: TipoDeProducto;

    estadoId: number;
    estado: Estado;

    historialCilindros: HistorialCilindro;
    historialDeFacturas: HistorialDeFactura[];
}

