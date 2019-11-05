import { EntityBase } from './Base/EntityBase';
import { Cliente } from './Cliente';
import { Bodega } from './Bodega';
import { Departamento } from './Departamento';

export interface Ciudad extends EntityBase<number> {
    nombreCiudad: string;

    departamentoId: number;
    departamento: Departamento;
    bodegas: Bodega[];
    clientes: Cliente[];
}

