import { EntityBase } from './Base/EntityBase';
import { Ciudad } from './Ciudad';

    export interface Departamento extends EntityBase<number>{
        nombreDepartamento: string;
        ciudades: Ciudad[];
    }

