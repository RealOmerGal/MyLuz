import { QueryClient, QueryClientProvider } from "react-query";
import ServiceTypes from "./pages/ServiceTypes";
import "./styles/global.css";
function App() {
  const queryClient = new QueryClient();
  return (
    <QueryClientProvider client={queryClient}>
      <ServiceTypes />
    </QueryClientProvider>
  );
}

export default App;
