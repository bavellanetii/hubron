import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { SideBarComponent } from './side-bar/side-bar.component';
import { RouterModule } from '@angular/router';
import { SectionHeaderComponent } from './section-header/section-header.component';



@NgModule({
  declarations: [NavBarComponent, SideBarComponent, SectionHeaderComponent],
  imports: [
    CommonModule,
    RouterModule
  ],
  exports: [NavBarComponent, SideBarComponent, SectionHeaderComponent]
})
export class CoreModule { }
