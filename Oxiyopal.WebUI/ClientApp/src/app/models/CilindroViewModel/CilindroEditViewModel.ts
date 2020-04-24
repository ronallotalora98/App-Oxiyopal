import { Cilindro } from '../Cilindro';
import { HistorialCilindro } from '../ViewModels/HistorialCilindro';

export class CilindroEditViewModel {
    cilindro: Cilindro;
    historial: HistorialCilindro;
    ubicacion: CurrentUbicacion;
}

export class CurrentUbicacion {
    idUbicacion: number;
    nombreUbicacion: string;
    idClienBodeg: number;
    isBodega: boolean;
}
