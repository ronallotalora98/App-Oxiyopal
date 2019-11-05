import { EntityBase } from './Base/EntityBase';
import { HistorialDeFactura } from './ViewModels/HistorialDeFactura';
import { Cliente } from './Cliente';

export interface Factura extends EntityBase<number> {
    valor: number;
    serial: number;
    fechaDeVenta: Date | string;
    clienteId: number;
    cliente: Cliente;
    historialDeFacturas: HistorialDeFactura[];
}

