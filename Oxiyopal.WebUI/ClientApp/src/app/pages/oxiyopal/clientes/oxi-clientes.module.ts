import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { OxiClientesComponent } from './oxi-clientes.component';
import { AddClienteModule } from './add-cliente/add-cliente.module';
import { ListClienteModule } from './list-cliente/list-cliente.module';
import { OxiClientesRoutingModule } from './oxi-clientes.routing';

@NgModule({
  imports: [
    CommonModule,
    AddClienteModule,
    ListClienteModule,
    OxiClientesRoutingModule,
  ],
  declarations: [OxiClientesComponent],
})
export class OxiClientesModule { }
