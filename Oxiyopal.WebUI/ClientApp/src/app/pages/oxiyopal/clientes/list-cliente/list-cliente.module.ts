import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { ListClienteComponent } from './list-cliente.component';
import { NbCardModule, NbInputModule } from '@nebular/theme';
import { NgxSpinnerModule } from 'ngx-spinner';
import { Ng2SmartTableModule } from 'ng2-smart-table';


const routes: Routes = [{ path: '', component: ListClienteComponent }];
@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    NbCardModule,
    NgxSpinnerModule,
    Ng2SmartTableModule,
    NbInputModule,
  ],
  declarations: [ListClienteComponent],
})
export class ListClienteModule { }