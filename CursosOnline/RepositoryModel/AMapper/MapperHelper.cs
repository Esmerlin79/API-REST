using System;
using AutoMapper;
using System.Collections.Generic;
using System.Text;
using RepositoryModel.ViewModel;
using RepositoryModel.Model;

namespace RepositoryModel.AMapper
{
    public class MapperHelper
    {
        static MapperHelper _instance;

         private MapperHelper()
        {
            Mapper.Initialize(conf => {

                conf.CreateMap<CursoViewModel, Curso>()
                .ForMember(to => to.Titulo, exps => exps.MapFrom(from => from.Nombre));
                conf.CreateMap<Curso, CursoViewModel>()
                .ForMember(to => to.Nombre, exps => exps.MapFrom(from => from.Titulo));
                //    .ForMember(to => to.empresa, exps => exps.MapFrom(from => from.idcia));

            });

        }
 
        public static MapperHelper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MapperHelper();

                return _instance;
            }
        }

        public To Map<From, To>(From obj)
        {
            return Mapper.Map<To>(obj);
        }

        public To Map<From, To>(From from, To to)
        {
            return Mapper.Map(from, to);
        }
    }
}
