export class CilindroSearhResultViewModel {

    cilindros: CilindroResult;
}

export class CilindroResult {
    cilindroId: number;
    serial: string;
    ubicacion: UbicacionResult;

}

export class UbicacionResult {
    estaEnBodega: boolean;
    nombreUbicacion: string;
    fechaDeTraslado: Date | string;
}

