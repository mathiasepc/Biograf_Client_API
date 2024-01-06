import { Component } from '@angular/core';
import { ApiService } from 'src/Service/ApiService.service';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css'],
})
export class AdminComponent {
  modelData: any[] = [];
  columnNames: string[] = [];

  options: { value: string, label: string }[] = [
    { value: '', label: 'Vælg venligst..' },
    { value: 'actor', label: 'Skuespiller' },
    { value: 'cinema', label: 'Biograf' },
    { value: 'hall', label: 'Biograf hal' },
    { value: 'movie', label: 'Film' },
    { value: 'date', label: 'Kalender' },
    { value: 'theme', label: 'Genre' },
    { value: 'user', label: 'User' }
  ];

  constructor(private api: ApiService) {}

  onSelectChange(event: any) {
    console.log('onSelectChange');
    // Henter den valgte fra select.
    const selectedModel = event.target.value;

    if (selectedModel) {
      this.api.getModelData(selectedModel).subscribe({
        next: (apiResult) => {
          console.log(`apiResult ${{apiResult}}`)
          this.modelData = apiResult;
      
          // Assuming the array is not empty
          if (this.modelData.length > 0) {
            // Get column names from the first object
            this.columnNames = Object.keys(this.modelData[0]);
          }
        },
        error: (error) => {
          console.error('Error fetching data:', error);
        }
      });
    }
  }
}
