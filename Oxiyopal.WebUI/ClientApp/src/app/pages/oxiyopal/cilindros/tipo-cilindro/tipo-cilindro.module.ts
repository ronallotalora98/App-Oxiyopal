import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TipoCilindroComponent } from './tipo-cilindro.component';
import { RouterModule, Routes } from '@angular/router';
import { NbCardModule, NbIconModule, NbButtonModule } from '@nebular/theme';

const routes: Routes = [{ path: '', component: TipoCilindroComponent }];
@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    NbCardModule,
    NbIconModule,
    NbButtonModule,
  ],
  declarations: [TipoCilindroComponent],
})
export class TipoCilindroModule { }
