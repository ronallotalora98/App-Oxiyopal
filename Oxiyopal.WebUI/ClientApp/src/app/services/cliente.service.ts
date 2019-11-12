import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Cliente } from '../models/Cliente';

@Injectable({
  providedIn: 'root',
})
export class ClienteService {
  private baseUrl: string = environment.urlApi;
  constructor(private http: HttpClient) { }

  CreateNewClient(cliente: Cliente) {
    const callUrl = `${this.baseUrl}/Cliente/createCliente`;
    return this.http.post(callUrl, cliente);
  }
}
