import axiosInstance from "../../config/axiosInstance";
import { CreateServiceTypeDto, ServiceType } from "../../models/serviceType";

const addServiceType = async (dto: CreateServiceTypeDto) => {
  return await axiosInstance.post<ServiceType>("/services", dto);
};

const removeServiceType = async (id: ServiceType["id"]) => {
  return await axiosInstance.delete<ServiceType>(`/services/${id}`);
};

export const mutations = {
  addServiceType,
  removeServiceType,
};
