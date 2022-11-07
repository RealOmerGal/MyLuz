export interface CreateServiceTypeDto {
  title: string;
  price: number;
  timeFrame: number;
}
export interface ServiceType extends CreateServiceTypeDto {
  id: string;
}
