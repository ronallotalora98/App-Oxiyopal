import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs';
import { CreateCilinderViewModel } from '../models/CilindroViewModel/CreateCilinderViewModel';
import { HttpClient } from '@angular/common/http';
import { Cilindro } from '../models/Cilindro';
import { CilindroSearhResultViewModel } from '../models/CilindroViewModel/CilindroSearhResultViewModel';

@Injectable({
  providedIn: 'root',
})
export class CilindroService {

  private baseUrl: string = environment.urlApi;
  constructor(private http: HttpClient) { }

  GetStatusAndTypeProduc(): Observable<CreateCilinderViewModel> {
    const callUrl = `${this.baseUrl}/Cilindro/formCreate`;
    return this.http.get<CreateCilinderViewModel>(callUrl);
  }

  CreateNewCilinder(cilindro: Cilindro) {
    const callUrl = `${this.baseUrl}/Cilindro/createCilinder`;
    return this.http.post(callUrl, cilindro);
  }

  GetCilindersForType(type: string): Observable<CilindroSearhResultViewModel> {
    const callUrl = `${this.baseUrl}/Cilindro/getCilinder/${type}`;
    return this.http.get<CilindroSearhResultViewModel>(callUrl);
  }

  GetCilindro(cilindroId: number): Observable<any> {
    const callUrl = `${this.baseUrl}/Cilindro/obtenerCilindro/${cilindroId}`;
    return this.http.get<any>(callUrl);
  }

  UpdateNewCilinder(cilindro: Cilindro) {
    const callUrl = `${this.baseUrl}/Cilindro/updateCilinder`;
    return this.http.put(callUrl, cilindro);
  }
}
