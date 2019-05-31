import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ArmyListInfoComponent } from './army-list-info/army-list-info.component';
import { ArmyListRoutesModule } from './army-list-routing';

@NgModule({
  declarations: [ArmyListInfoComponent],
  imports: [CommonModule, ArmyListRoutesModule],
})
export class ArmyListModule {}
