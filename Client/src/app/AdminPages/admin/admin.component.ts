import { Component } from '@angular/core';
import { ApiService } from 'src/Service/ApiService.service';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css'],
})
export class AdminComponent {
  modelData: any[] = [];
  // returnerer navnet på den string som den er ved at behandle i html.
  objectKeys = Object.keys;

  constructor(private api: ApiService) {}

  onSelectChange(event: any) {
    // Henter den valgte fra select.
    const selectedModel = event.target.value;

    if (selectedModel) {
      this.api.getModelData(selectedModel).subscribe({
        next: (apiResult) => {
          this.modelData = apiResult;
          // // Brug Object.entries() til at få en matrice af [nøgle, værdi] for hver egenskab i objektet
          // const entries = Object.entries(apiResult);

          // // Log hver egenskab og dens værdi
          // entries.forEach(([key, value]) => {
          //   console.log(`${key}: ${value}`);
          // });
          // this.modelData.forEach((model, index) => {
          //   console.log(`Model ${index + 1}:`);
            
          //   // Loop gennem egenskaberne for det aktuelle objekt
          //   Object.entries(model).forEach(([key, value]) => {
          //     console.log(`${key}: ${value}`);
          //   });
          // });
        },
        error: (error) => {
          console.log(`Noget gik galt: ${error}`);
        },
      });
    }
  }
}
