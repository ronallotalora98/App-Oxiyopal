import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { NbCardModule, NbIconModule, NbRadioModule,
   NbSelectModule, NbToastrModule, NbButtonModule, NbInputModule } from '@nebular/theme';
import { AddCilindroComponent } from './add-cilindro.component';
import { FormsModule } from '@angular/forms';
import { CilindroService } from '../../../../services/cilindro.service';

const routes: Routes = [{ path: '', component: AddCilindroComponent }];
@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    NbCardModule,
    NbIconModule,
    NbRadioModule,
    NbSelectModule,
    FormsModule,
    NbToastrModule,
    NbButtonModule,
    NbInputModule,
  ],
  declarations: [AddCilindroComponent],
  providers: [CilindroService],
})
export class AddCilindroModule { }