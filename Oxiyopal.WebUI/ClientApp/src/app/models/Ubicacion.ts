import { EntityBase } from './Base/EntityBase';
import { HistorialCilindro } from './ViewModels/HistorialCilindro';
import { Cliente } from './Cliente';
import { Bodega } from './Bodega';

export interface Ubicacion extends EntityBase<number> {
    estaEnBodega: boolean;
    fechaDeTraslado: Date | string;

    clienteId: number;
    cliente: Cliente;
    bodegaId: number;
    bodega: Bodega;
    historialCilindros: HistorialCilindro[];
}

