import { EntityBase } from './Base/EntityBase';
import { Ubicacion } from './Ubicacion';
import { Ciudad } from './Ciudad';

export interface Bodega extends EntityBase<number> {
    nombreBodega: string;
    direccion: string;

    ciudadId: number;
    ciudad: Ciudad;


    ubicaciones: Ubicacion[];
}

