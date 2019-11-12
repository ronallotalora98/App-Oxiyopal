import { EntityBase } from './Base/EntityBase';
import { Ciudad } from './Ciudad';

    export class Departamento extends EntityBase<number>{
        nombreDepartamento: string;
        ciudades: Ciudad[];
    }

