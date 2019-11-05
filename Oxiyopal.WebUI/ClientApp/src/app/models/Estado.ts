import { EntityBase } from './Base/EntityBase';
import { Cilindro } from './Cilindro';

export interface Estado extends EntityBase<number> {
    nombreDeEstado: string;
    colorDeEstado: string;
    cilindros: Cilindro[];
}

