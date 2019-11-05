import { Cilindro } from '../Cilindro';
import { Factura } from '../Factura';
import { EntityBase } from '../Base/EntityBase';

export interface HistorialDeFactura extends EntityBase<number> {
    cilindroId: number;
    cilindro: Cilindro;

    facturaId: number;
    factura: Factura;
}

