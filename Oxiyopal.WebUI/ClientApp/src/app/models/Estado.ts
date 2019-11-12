import { EntityBase } from './Base/EntityBase';
import { Cilindro } from './Cilindro';

export class Estado extends EntityBase<number> {
    nombreDeEstado: string;
    colorDeEstado: string;
    cilindros: Cilindro[];
}

