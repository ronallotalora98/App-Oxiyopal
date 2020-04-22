import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EditCilidrosComponent } from './edit-cilidros.component';
import { EditCilindrosFormModule } from './components/edit-cilindros-form/edit-cilindros-form.module';
import { HistorialCilindrosModule } from './components/historial-cilindros/historial-cilindros.module';
import { RouterModule, Routes } from '@angular/router';
import { Ng2SmartTableModule } from 'ng2-smart-table';
import {
  NbCardModule, NbIconModule, NbInputModule,
  NbButtonModule, NbCheckboxModule, NbRadioModule, NbSelectModule, NbToastrModule,
} from '@nebular/theme';
import { FormsModule } from '@angular/forms';
import { NgxSpinnerModule } from 'ngx-spinner';

const routes: Routes = [{ path: '', component: EditCilidrosComponent }];
@NgModule({
  imports: [
    CommonModule,
    EditCilindrosFormModule,
    HistorialCilindrosModule,
    RouterModule.forChild(routes),
    Ng2SmartTableModule,
    NbCardModule,
    NbIconModule,
    NbButtonModule,
    NbInputModule,
    NbCheckboxModule,
    NbRadioModule,
    NbSelectModule,
    FormsModule,
    NbToastrModule,
    RouterModule,
    NgxSpinnerModule,
  ],
  declarations: [EditCilidrosComponent],
})
export class EditCilidrosModule { }
