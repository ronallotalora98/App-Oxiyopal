import { EntityBase } from '../Base/EntityBase';
import { Cilindro } from '../Cilindro';
import { Ubicacion } from '../Ubicacion';

export class HistorialCilindro extends EntityBase<number> {
    cilindroId: number;
    cilindro: Cilindro;

    ubicacionId: number;
    ubicacion: Ubicacion;

    esUbucacionActual: boolean;
}

