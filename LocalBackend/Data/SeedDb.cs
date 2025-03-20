using LocalShared.Entities.Eventos;
using LocalShared.Entities.Medicion;

namespace LocalBackend.Data
{
    public class SeedDb
    {
        public DataContext _context { get; }
        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckMarcaAsync();
            await CheckMedioAsync();
            await CheckTipoElemento();
            await CheckTipoDispositivoAsync();
            await CheckTipoMedicionAsync();
            await CheckSistemaAsync();
            await CheckAsigacionMedio();
            await CheckImpacto();
        }


        private async Task CheckImpacto()
        {
            if (!_context.Impacto.Any())
            {
                _context.Impacto.Add(new ClsMImpacto
                {
                    IdImpacto = Guid.Parse("eac06e63-7a9d-4fad-9bc0-b33425351ae1"),
                    Nombre = "Positivo",
                    tipoEventos =
                    [
                        new ClsMTipoEvento()
                        {
                            IdTipoEvento = Guid.Parse("0b7a1f1e-c64b-4147-9fee-706ede41fb54"),
                            Nombre = "Siembra"
                        },
                        new ClsMTipoEvento()
                        {
                            IdTipoEvento = Guid.Parse("3cbec115-f508-44ce-986b-bbeccfd3af8e"),
                            Nombre = "Ingreso de peces"
                        },
                        new ClsMTipoEvento()
                        {
                            IdTipoEvento = Guid.Parse("e14a82c7-7ad6-48ad-8ce0-587197611d12"),
                            Nombre = "Ingreso de excretas"
                        },

                    ]
                });
                _context.Impacto.Add(new ClsMImpacto
                {
                    IdImpacto = Guid.Parse("f6915a14-11da-43c1-944b-d2b05ff3c40c"),
                    Nombre = "Negativo",
                    tipoEventos =
                    [
                        new ClsMTipoEvento()
                        {
                            IdTipoEvento = Guid.Parse("6f950c76-e433-4f02-8af1-99edc5d6f87c"),
                            Nombre = "Cosecha"
                        },
                        new ClsMTipoEvento()
                        {
                            IdTipoEvento = Guid.Parse("d8fdf5b8-3de4-4959-96d7-d191aa1d5709"),
                            Nombre = "Cosecha de peces"
                        },
                        new ClsMTipoEvento()
                        {
                            IdTipoEvento = Guid.Parse("2476bbd2-12a3-4add-bcaa-aabbb8794ed0"),
                            Nombre = "Extracción de biol"
                        }
                    ]
                });
                _context.Impacto.Add(new ClsMImpacto
                {
                    IdImpacto = Guid.Parse("0b7a1f1e-c64b-4147-9fee-706ede41fb54"),
                    Nombre = "Sin Impacto",
                    tipoEventos =
                    [
                        new ClsMTipoEvento()
                        {
                            IdTipoEvento = Guid.Parse("229e7683-c75e-404c-a599-c148e187da25"),
                            Nombre = "Fumigación",
                            eventos =
                            [
                                new ClsMEvento()
                                {
                                    IdEvento= Guid.NewGuid(),
                                    FechaEvento= DateTime.UtcNow
                                },
                                new ClsMEvento()
                                {
                                    IdEvento= Guid.NewGuid(),
                                    FechaEvento= DateTime.UtcNow
                                }
                            ]
                        },
                        new ClsMTipoEvento()
                        {
                            IdTipoEvento = Guid.Parse("6382ba7c-5020-48a3-b923-42202cf6ae1a"),
                            Nombre = "Poda"
                        },
                        new ClsMTipoEvento()
                        {
                            IdTipoEvento = Guid.Parse("fcb16401-ce39-4bce-b57b-91aafc2f091b"),
                            Nombre = "Monitoreo de calidad del agua"
                        },
                        new ClsMTipoEvento()
                        {
                            IdTipoEvento = Guid.Parse("be1e33e6-eb7e-49ee-bdcf-8049416d0ced"),
                            Nombre = "Limpieza de tanques"
                        },
                        new ClsMTipoEvento()
                        {
                            IdTipoEvento = Guid.Parse("acfee72d-7aea-49f4-a59a-8fb631d76121"),
                            Nombre = "Mantenimiento del biodigestor"
                        },
                        new ClsMTipoEvento()
                        {
                            IdTipoEvento = Guid.Parse("09e65988-c789-4b77-89c7-5f466a5f00af"),
                            Nombre = "Volteo del compost"
                        },
                        new ClsMTipoEvento()
                        {
                            IdTipoEvento = Guid.Parse("979df9f4-5989-4ea4-abf4-4ac54e360a13"),
                            Nombre = "Monitoreo de temperatura"
                        },
                        new ClsMTipoEvento()
                        {
                            IdTipoEvento = Guid.Parse("a0d456be-a681-4f6b-9ac9-74db4117c616"),
                            Nombre = "Inspección del sistema"
                        },
                        new ClsMTipoEvento()
                        {
                            IdTipoEvento = Guid.Parse("b4866bc3-22bb-436b-bdcb-4ee082e06509"),
                            Nombre = "Registro de datos"
                        },
                        new ClsMTipoEvento()
                        {
                            IdTipoEvento = Guid.Parse("0ae2805d-8836-4bb8-88c5-7b914780b7bb"),
                            Nombre = "Capacitación"
                        }

                    ]
                });
                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckSistemaAsync()
        {
            if (!_context.Sistema.Any())
            {
                _context.Sistema.Add(new LocalShared.Entities.Sistemas.ClsMSistema { IdSistema = Guid.Parse("a6eb4134-0a19-4191-b6bc-7e7904c829d3"), Nombre = "Acuicultura" });
                _context.Sistema.Add(new LocalShared.Entities.Sistemas.ClsMSistema { IdSistema = Guid.Parse("50e4fa86-2a59-4e0b-8e47-61ed60e6737f"), Nombre = "Cultivo " });
                _context.Sistema.Add(new LocalShared.Entities.Sistemas.ClsMSistema { IdSistema = Guid.Parse("af459eb8-e616-4e8d-a79c-32320b59d4e3"), Nombre = "Biodigestor" });
                _context.Sistema.Add(new LocalShared.Entities.Sistemas.ClsMSistema { IdSistema = Guid.Parse("7960e3a6-6e60-4679-afc0-899643ecafb3"), Nombre = "Compostaje" });
                _context.Sistema.Add(new LocalShared.Entities.Sistemas.ClsMSistema { IdSistema = Guid.Parse("161a6882-7992-4d0f-89ef-2b16d04c9fcd"), Nombre = "Energia Solar " });
                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckTipoMedicionAsync()
        {
            if (!_context.TipoMedicion.Any())
            {
                _context.TipoMedicion.Add(new ClsMTipoMedicion
                {
                    IdTipoMedicion = Guid.Parse("e6e6a11f-f6b7-4d78-818b-6979681bd083"),
                    Nombre = "Longitud (Distancia)",
                    unidadMedidas = new List<ClsMUnidadMedida>()
                    {
                        new ClsMUnidadMedida()
                        {
                            IdUnidadMedida = Guid.Parse("1a2b3c4d-5e6f-4a7b-8c9d-0e1f2a3b4c5d"),
                            Nombre = "Metro",
                            Simbolo = "m",
                        },

                        new ClsMUnidadMedida()
                        {
                            IdUnidadMedida = Guid.Parse("2b3c4d5e-6f7a-4b8c-9d0e-1f2a3b4c5d6e"),
                            Nombre = "Kilómetro", Simbolo = "km"
                        },
                        new ClsMUnidadMedida()
                        {
                            IdUnidadMedida = Guid.Parse("3c4d5e6f-7a8b-4c9d-0e1f-2a3b4c5d6e7f"),
                            Nombre = "Centímetro",
                            Simbolo = "cm"
                        },
                        new ClsMUnidadMedida()
                        {
                            IdUnidadMedida = Guid.Parse("cfcf1f97-4bcb-429b-a986-8d808589fb3d"),
                            Nombre = "Milímetro",
                            Simbolo = "mm",
                        },
                        new ClsMUnidadMedida()
                        {
                            IdUnidadMedida = Guid.Parse("2d02c474-1b52-47fd-8426-dfc7752ba1c2"),
                            Nombre = "Pulgada",
                            Simbolo = "in"
                        },
                        new ClsMUnidadMedida()
                        {
                            IdUnidadMedida = Guid.Parse("b9004700-4a2c-4dce-99be-6582554572de"),
                            Nombre = "Pie",
                            Simbolo = "ft"
                        },
                        new ClsMUnidadMedida()
                        {
                            IdUnidadMedida = Guid.Parse("523b8f7b-edbc-483e-8996-1acebf5582a8"),
                            Nombre = "Milla",
                            Simbolo = "mi"
                        }
                    }
                });
                _context.TipoMedicion.Add(new ClsMTipoMedicion
                {
                    IdTipoMedicion = Guid.Parse("a1b2c3d4-e5f6-4a7b-8c9d-0e1f2a3b4c5d"),
                    Nombre = "Masa/Peso",
                    unidadMedidas = new List<ClsMUnidadMedida>()
                        {
                            new ClsMUnidadMedida()
                            {
                                IdUnidadMedida = Guid.Parse("ac7f7f28-3664-4e19-b319-85f466a9d8c1"),
                                Nombre = "Kilogramo",
                                Simbolo = "kg"
                            },
                            new ClsMUnidadMedida()
                            {
                                IdUnidadMedida = Guid.Parse("0255c15d-bf74-43ce-bb06-ae1b5518f38b"),
                                Nombre = "Gramo",
                                Simbolo = "g"
                            },
                            new ClsMUnidadMedida()
                            {
                                IdUnidadMedida = Guid.Parse("50364912-17aa-43fe-8ba3-022dae61e903"),
                                Nombre = "Miligramo",
                                Simbolo = "mg"
                            },
                            new ClsMUnidadMedida()
                            {
                                IdUnidadMedida = Guid.Parse("0892f4a0-a9e0-40cd-b1f9-35473cc1173b"),
                                Nombre = "Tonelada",
                                Simbolo = "t"
                            },
                            new ClsMUnidadMedida()
                            {
                                IdUnidadMedida = Guid.Parse("5056f514-449c-4b05-a6ce-b01a33a42f81"),
                                Nombre = "Libra",
                                Simbolo = "lb"
                            },
                            new ClsMUnidadMedida()
                            {
                                IdUnidadMedida = Guid.Parse("dc0531f0-af8f-4cf4-aebd-b512a8a307be"),
                                Nombre = "Onza",
                                Simbolo = "oz"
                            }
                        }
                });
                _context.TipoMedicion.Add(new ClsMTipoMedicion
                {
                    IdTipoMedicion = Guid.Parse("b2c3d4e5-f6a7-4b8c-9d0e-1f2a3b4c5d6e"),
                    Nombre = "Tiempo",
                    unidadMedidas = new List<ClsMUnidadMedida>()
                    {
                        new ClsMUnidadMedida()
                        {
                            IdUnidadMedida = Guid.Parse("538efe2c-a200-4234-bcf8-43647e78c723"),
                            Nombre = "Segundo",
                            Simbolo = "s"
                        },
                        new ClsMUnidadMedida()
                        {
                            IdUnidadMedida = Guid.Parse("d7318c08-fbaa-4cd0-8848-29812e8b3224"),
                            Nombre = "Minuto",
                            Simbolo = "min"
                        },
                        new ClsMUnidadMedida()
                        {
                            IdUnidadMedida = Guid.Parse("b07fd9f0-4020-45ac-b8b5-f04fd4a3961e"),
                            Nombre = "Hora",
                            Simbolo = "h"
                        },
                        new ClsMUnidadMedida()
                        {
                            IdUnidadMedida = Guid.Parse("71c08da4-d1e5-4ea5-8577-444f89714bbe"),
                            Nombre = "Día",
                            Simbolo = ""
                        },
                        new ClsMUnidadMedida()
                        {
                            IdUnidadMedida = Guid.Parse("d9c6af88-7619-435d-9a14-8439328ea1ac"),
                            Nombre = "Semana",
                            Simbolo = ""
                        },
                        new ClsMUnidadMedida()
                        {
                            IdUnidadMedida = Guid.Parse("3f57aa9f-7c44-4fbe-9520-5936a3a190d5"),
                            Nombre = "Año",
                            Simbolo = ""
                        }
                    }
                });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckTipoDispositivoAsync()
        {
            if (!_context.TipoDispositivo.Any())
            {
                _context.TipoDispositivo.Add(new LocalShared.Entities.Dispositivos.ClsMTipoDispositivo { IdTipoDispositivo = Guid.Parse("e6e6a11f-f6b7-4d78-818b-6979681bd083"), Nombre = "Sensores" });
                _context.TipoDispositivo.Add(new LocalShared.Entities.Dispositivos.ClsMTipoDispositivo { IdTipoDispositivo = Guid.Parse("2835df4f-5d6a-4f04-833b-11464e706790"), Nombre = "Actuadores" });
                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckMedioAsync()
        {
            if (!_context.Medio.Any())
            {
                //Algunos medios de produccion para Plantas
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("692dcfd7-e88f-4ffe-b79c-db2c38177466"), Nombre = "NFT (Nutrient Film Technique)" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("dbc0cb09-aca0-4f44-9aa6-234cd1ee3e60"), Nombre = "Cama de Grava" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("95bfac3f-db7c-44b9-88c9-9d411976d4c7"), Nombre = "Sustrato de Coco" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("43a88401-9ff1-446a-adbe-665358197e7f"), Nombre = "Sustrato de Perlita" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("0ad5d595-372d-498c-8d30-23cf5e318626"), Nombre = "Sustrato de Vermiculita" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("a9231d7c-b657-45df-8500-590ddba4c41a"), Nombre = "Suelo Tradicional" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("a3d6c232-782f-4b5c-9d28-ba700ac44db1"), Nombre = "Aeroponía" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("a33234a2-21d0-4424-9ba0-b1ca692c8323"), Nombre = "Acuaponía" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("8ab20412-a335-4f4c-b02e-eb6aae006f5d"), Nombre = "Cultivo en Agua Profunda (DWC)" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("aa86816e-e3d6-4cda-be59-e327166a8438"), Nombre = "Sustrato de Lana de Roca" });
                //Algunos medios de produccion para Peces
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("3b71b063-d010-478b-ba0f-94363b57ea15"), Nombre = "Estanques de Tierra" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("81bed0b3-5f19-4872-8373-57807abcc261"), Nombre = "Tanques de Fibra de Vidrio" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("fc551b51-75a1-44c3-9d1e-1c26af5ed768"), Nombre = "Jaulas Flotantes" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("28b205c9-e56d-43ab-a58d-341aa883cae8"), Nombre = "Sistema de Recirculación de Agua (RAS)" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("c4ea2c62-eb88-4eb6-bd10-3e5ce4edf3a1"), Nombre = "Raceways" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("6d36b693-5ff1-430a-b53e-221d2450aca9"), Nombre = "Estanques de Concreto" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("5047d219-026a-4bd1-9a1b-7175cec4af1e"), Nombre = "Biofloc" });
                //Biodigestor
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("e6913d40-09eb-4280-a238-adb6dc81a7c4"), Nombre = "Biodigestor de Flujo Continuo" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("68719868-a636-40bf-8d17-305c6bda0354"), Nombre = "Biodigestor de Cúpula Fija" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("c18a7815-a246-460e-a36d-99a0c0d40531"), Nombre = "Biodigestor de Batch" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("09b25658-be94-4171-b252-bb634d52a294"), Nombre = "Biodigestor de Tubo" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("29500a8d-8814-457a-bb13-4a759a3971c0"), Nombre = "Biodigestor de Cúpula Flotante" });
                //Compostera
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("fa74ab5a-3e33-4eea-9f3a-5344266d8e75"), Nombre = "Compostera de Tambor" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("aadd88fd-6a3d-4733-a2b0-6e93e2a3567f"), Nombre = "Compostera de Pila" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("5e79325e-d58b-4502-ad99-99fcfbbc3fe1"), Nombre = "Compostera de Vermicompostaje" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("9e6b5d43-da49-400e-a5cc-4fa2dc1aa66b"), Nombre = "Compostera de Trinchera" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("87c1042a-793a-4daf-92ac-4c657fc6ed45"), Nombre = "Compostera de Caja" });
                //Sistemas de Energía Solar
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("cfc6b207-9c10-42dd-aa26-3abb04907f5c"), Nombre = "Paneles Solares Fotovoltaicos" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("fcf7e32e-3bbb-47a1-ac62-6d2fa4d77a59"), Nombre = "Colectores Solares Térmicos" });
                _context.Medio.Add(new LocalShared.Entities.Sistemas.ClsMMedio { IdMedio = Guid.Parse("adbb029e-af64-4b68-8101-ef1d86c53c6a"), Nombre = "Sistemas de Concentración Solar" });

                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckTipoElemento()
        {
            if (!_context.TipoElemento.Any())
            {
                _context.TipoElemento.Add(new LocalShared.Entities.Elementos.ClsMTipoElemento { IdTipoElemento = Guid.Parse("33b77003-e06c-4a4a-b134-b36eec5a478d"), Nombre = "Plantas" });
                _context.TipoElemento.Add(new LocalShared.Entities.Elementos.ClsMTipoElemento { IdTipoElemento = Guid.Parse("bf625888-549d-4b9b-84a0-720ce2831c00"), Nombre = "Peces" });
                _context.TipoElemento.Add(new LocalShared.Entities.Elementos.ClsMTipoElemento { IdTipoElemento = Guid.Parse("be7aeff5-dc61-429c-b804-a4b133292d49"), Nombre = "Excretas" });
                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckMarcaAsync()
        {
            if (!_context.Marca.Any())
            {
                _context.Marca.Add(new LocalShared.Entities.Dispositivos.ClsMMarca { IdMarca = Guid.Parse("80e37a00-c06e-478b-9deb-0b398f6c0433"), Nombre = "Arduino" });
                _context.Marca.Add(new LocalShared.Entities.Dispositivos.ClsMMarca { IdMarca = Guid.Parse("20d2b965-9ef2-4ee9-a587-0b931c0b26a5"), Nombre = "Generic" });
                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckAsigacionMedio()
        {
            if (!_context.AsignacionMedio.Any())
            {
                // Asignación de Plantas a medios de cultivo
                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("151ce505-5f73-40f3-871d-c7e23a47eb28"),
                    IdMedio = Guid.Parse("692dcfd7-e88f-4ffe-b79c-db2c38177466"), // NFT (Nutrient Film Technique)
                    IdTipoElemento = Guid.Parse("33b77003-e06c-4a4a-b134-b36eec5a478d") // Plantas
                });

                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("2eb8d663-8a31-4921-94e1-49853d3df10b"),
                    IdMedio = Guid.Parse("dbc0cb09-aca0-4f44-9aa6-234cd1ee3e60"), // Cama de Grava
                    IdTipoElemento = Guid.Parse("33b77003-e06c-4a4a-b134-b36eec5a478d") // Plantas
                });

                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("c2543edb-c938-4b68-bd55-ace347f35260"),
                    IdMedio = Guid.Parse("95bfac3f-db7c-44b9-88c9-9d411976d4c7"), // Sustrato de Coco
                    IdTipoElemento = Guid.Parse("33b77003-e06c-4a4a-b134-b36eec5a478d") // Plantas
                });

                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("882ea516-29f6-46e3-9f79-1dc2913a2242"),
                    IdMedio = Guid.Parse("43a88401-9ff1-446a-adbe-665358197e7f"), // Sustrato de Perlita
                    IdTipoElemento = Guid.Parse("33b77003-e06c-4a4a-b134-b36eec5a478d") // Plantas
                });

                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("8e99aade-0f1d-4ce2-8db3-29b2bba03c83"),
                    IdMedio = Guid.Parse("0ad5d595-372d-498c-8d30-23cf5e318626"), // Sustrato de Vermiculita
                    IdTipoElemento = Guid.Parse("33b77003-e06c-4a4a-b134-b36eec5a478d") // Plantas
                });

                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("165d3113-a1b6-4f46-9d27-16292f6134bc"),
                    IdMedio = Guid.Parse("a9231d7c-b657-45df-8500-590ddba4c41a"), // Suelo Tradicional
                    IdTipoElemento = Guid.Parse("33b77003-e06c-4a4a-b134-b36eec5a478d") // Plantas
                });

                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("759fa6b5-0c78-4c2e-a76d-6df5c2eb4193"),
                    IdMedio = Guid.Parse("a3d6c232-782f-4b5c-9d28-ba700ac44db1"), // Aeroponía
                    IdTipoElemento = Guid.Parse("33b77003-e06c-4a4a-b134-b36eec5a478d") // Plantas
                });

                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("1b993f65-b711-4e04-8c85-3354242ccb75"),
                    IdMedio = Guid.Parse("8ab20412-a335-4f4c-b02e-eb6aae006f5d"), // Cultivo en Agua Profunda (DWC)
                    IdTipoElemento = Guid.Parse("33b77003-e06c-4a4a-b134-b36eec5a478d") // Plantas
                });

                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("42e2f4a3-fd17-4b02-b29e-bc7183f04d4a"),
                    IdMedio = Guid.Parse("aa86816e-e3d6-4cda-be59-e327166a8438"), // Sustrato de Lana de Roca
                    IdTipoElemento = Guid.Parse("33b77003-e06c-4a4a-b134-b36eec5a478d") // Plantas
                });

                // Asignación de Peces a medios de acuicultura
                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("5b9233dd-1dc0-4538-bc37-b26936d55440"),
                    IdMedio = Guid.Parse("3b71b063-d010-478b-ba0f-94363b57ea15"), // Estanques de Tierra
                    IdTipoElemento = Guid.Parse("bf625888-549d-4b9b-84a0-720ce2831c00") // Peces
                });

                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("70a466d6-d0c8-44b3-a1fc-91e0dc6c0143"),
                    IdMedio = Guid.Parse("81bed0b3-5f19-4872-8373-57807abcc261"), // Tanques de Fibra de Vidrio
                    IdTipoElemento = Guid.Parse("bf625888-549d-4b9b-84a0-720ce2831c00") // Peces
                });

                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("e40c7c5b-86bc-4092-be2f-d6301a50f4ce"),
                    IdMedio = Guid.Parse("fc551b51-75a1-44c3-9d1e-1c26af5ed768"), // Jaulas Flotantes
                    IdTipoElemento = Guid.Parse("bf625888-549d-4b9b-84a0-720ce2831c00") // Peces
                });

                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("23b163d0-a060-4efd-8c33-392fc6b2d4a7"),
                    IdMedio = Guid.Parse("28b205c9-e56d-43ab-a58d-341aa883cae8"), // Sistema de Recirculación de Agua (RAS)
                    IdTipoElemento = Guid.Parse("bf625888-549d-4b9b-84a0-720ce2831c00") // Peces
                });

                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("8e77beb8-1f77-4687-80ce-f19ca657d420"),
                    IdMedio = Guid.Parse("c4ea2c62-eb88-4eb6-bd10-3e5ce4edf3a1"), // Raceways
                    IdTipoElemento = Guid.Parse("bf625888-549d-4b9b-84a0-720ce2831c00") // Peces
                });

                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("3ff6df2c-6b0c-44fa-b1ee-9571746d64e4"),
                    IdMedio = Guid.Parse("6d36b693-5ff1-430a-b53e-221d2450aca9"), // Estanques de Concreto
                    IdTipoElemento = Guid.Parse("bf625888-549d-4b9b-84a0-720ce2831c00") // Peces
                });

                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("36c53a72-ef92-42ec-aff5-59e9d465cac0"),
                    IdMedio = Guid.Parse("5047d219-026a-4bd1-9a1b-7175cec4af1e"), // Biofloc
                    IdTipoElemento = Guid.Parse("bf625888-549d-4b9b-84a0-720ce2831c00") // Peces
                });

                // Asignación de Excretas a biodigestores y composteras
                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("57d472a8-4d64-400e-858d-73ccfde302c2"),
                    IdMedio = Guid.Parse("e6913d40-09eb-4280-a238-adb6dc81a7c4"), // Biodigestor de Flujo Continuo
                    IdTipoElemento = Guid.Parse("be7aeff5-dc61-429c-b804-a4b133292d49") // Excretas
                });

                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("f1e9c2b8-789e-40df-a632-8cd80cbbbe9a"),
                    IdMedio = Guid.Parse("68719868-a636-40bf-8d17-305c6bda0354"), // Biodigestor de Cúpula Fija
                    IdTipoElemento = Guid.Parse("be7aeff5-dc61-429c-b804-a4b133292d49") // Excretas
                });

                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("5a5f59b1-b651-462a-b971-b00458c5c576"),
                    IdMedio = Guid.Parse("c18a7815-a246-460e-a36d-99a0c0d40531"), // Biodigestor de Batch
                    IdTipoElemento = Guid.Parse("be7aeff5-dc61-429c-b804-a4b133292d49") // Excretas
                });

                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("5e1e7b9d-e293-42ae-b72c-355f7a834042"),
                    IdMedio = Guid.Parse("09b25658-be94-4171-b252-bb634d52a294"), // Biodigestor de Tubo
                    IdTipoElemento = Guid.Parse("be7aeff5-dc61-429c-b804-a4b133292d49") // Excretas
                });

                _context.AsignacionMedio.Add(new LocalShared.Entities.Sistemas.ClsMAsignacionMedio
                {
                    IdAsignacionMedio = Guid.Parse("ddbb1b63-58c5-4910-9dfb-65f0713c7abc"),
                    IdMedio = Guid.Parse("29500a8d-8814-457a-bb13-4a759a3971c0"), // Biodigestor de Cúpula Flotante
                    IdTipoElemento = Guid.Parse("be7aeff5-dc61-429c-b804-a4b133292d49") // Excretas
                });

                await _context.SaveChangesAsync();

            }
        }
    }
}
