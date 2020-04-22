import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddClienteComponent } from './add-cliente.component';
import { RouterModule, Routes } from '@angular/router';
import { AddCilindroComponent } from '../../cilindros/add-cilindro/add-cilindro.component';
import { NbCardModule, NbCheckboxModule, NbButtonModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { FormsModule } from '@angular/forms';

const routes: Routes = [{ path: '', component: AddCilindroComponent }];
@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    NbCardModule,
    FormsModule,
    NbCheckboxModule,
    NbButtonModule,
    NbIconModule,
    NbInputModule,
  ],
  declarations: [AddClienteComponent],
})
export class AddClienteModule { }
