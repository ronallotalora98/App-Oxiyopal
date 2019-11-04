import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AuthRoutingModule } from './auth-routing.module';
import { LoginComponent } from './login/login.component';
import { NbLayoutModule } from '@nebular/theme';

@NgModule({
  declarations: [LoginComponent],
  imports: [
    CommonModule,
    NbLayoutModule,
    AuthRoutingModule,
  ],
})
export class AuthModule { }
