import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { OxiCilindrosComponent } from './oxi-cilindros.component';
import { EditCilidrosModule } from './edit-cilindros/edit-cilidros.module';
import { ListCilindrosModule } from './list-cilindros/list-cilindros.module';
import { TipoCilindroModule } from './tipo-cilindro/tipo-cilindro.module';
import { OxiCilindrosRoutingModule } from './oxi-cilindros.routing';
import { CilindroService } from '../../../services/cilindro.service';
import { AddCilindroModule } from './add-cilindro/add-cilindro.module';
import { NbMenuModule } from '@nebular/theme';
import { ThemeModule } from '../../../@theme/theme.module';

@NgModule({
  imports: [
    CommonModule,
    EditCilidrosModule,
    ListCilindrosModule,
    TipoCilindroModule,
    OxiCilindrosRoutingModule,
    AddCilindroModule,
  ],
  declarations: [OxiCilindrosComponent],
  providers: [CilindroService],
})
export class OxiCilindrosModule { }
