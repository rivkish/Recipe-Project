using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;


namespace BLL.cast
{
    public class LayerCast
    {
        public LayerDTO GetLayerDTO(Layer layer)
        {
            return new LayerDTO()
            { Id = layer.Id,
              Description = layer.Description,
              Components = layer.Components
            };
        }

        public Layer GetLayer(LayerDTO layerDTO)
        {
            return new Layer() 
            { 
                Id = layerDTO.Id,
                Description = layerDTO.Description,
                Components = String.Join("#", layerDTO.Components) 
            };
        }

    }
}
