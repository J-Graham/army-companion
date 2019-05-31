import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ArmyListInfoComponent } from './army-list-info/army-list-info.component';

const routes: Routes = [{ path: '', component: ArmyListInfoComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [],
  declarations: [],
})
export class ArmyListRoutesModule {}
