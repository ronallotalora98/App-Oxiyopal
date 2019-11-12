import { EntityBase } from './Base/EntityBase';
import { Cilindro } from './Cilindro';

export class TipoDeProducto extends EntityBase<number> {
    nombreTipoProducto: string;
    color: string;

    cilindros: Cilindro[];
}

