import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { ListCilindrosComponent } from './list-cilindros.component';
import { NbCardModule, NbInputModule } from '@nebular/theme';
import { NgxSpinnerModule } from 'ngx-spinner';
import { Ng2SmartTableModule } from 'ng2-smart-table';


const routes: Routes = [{ path: '', component: ListCilindrosComponent }];
@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    NbCardModule,
    NbInputModule,
    NgxSpinnerModule,
    Ng2SmartTableModule,
  ],
  declarations: [ListCilindrosComponent],
})
export class ListCilindrosModule { }