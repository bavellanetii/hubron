import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login.component';
import { CoreModule } from '../core/core.module';
import { RouterModule } from '@angular/router';
import { AppRoutingModule } from '../app-routing.module';



@NgModule({
  declarations: [
    LoginComponent
  ],
  imports: [
    CommonModule,
    CoreModule,
    RouterModule,
    AppRoutingModule
  ],
  exports: [
    LoginComponent
  ]
})
export class LoginModule { }
