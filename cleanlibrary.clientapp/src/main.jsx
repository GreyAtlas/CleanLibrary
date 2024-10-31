import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import App from './app/layout/App.jsx'
import "bootswatch/dist/slate/bootstrap.min.css";

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <App />
  </StrictMode>,
)
