import { EntityBase } from './Base/EntityBase';
import { Cilindro } from './Cilindro';

export interface TipoDeProducto extends EntityBase<number> {
    nombreTipoProducto: string;
    color: string;

    cilindros: Cilindro[];
}

