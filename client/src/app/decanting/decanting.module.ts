import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DecantingComponent } from './decanting.component';
import {DragDropModule} from '@angular/cdk/drag-drop';


@NgModule({
  declarations: [
    DecantingComponent
  ],
  imports: [
    CommonModule
  ]
})
export class DecantingModule { }
