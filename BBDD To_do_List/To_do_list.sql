PGDMP                         z            ToDoList    14.1    14.1 	    ?           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            ?           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            ?           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            ?           1262    16394    ToDoList    DATABASE     f   CREATE DATABASE "ToDoList" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Spanish_Spain.1252';
    DROP DATABASE "ToDoList";
                postgres    false            ?            1259    24576    complete_task    TABLE     `   CREATE TABLE public.complete_task (
    id_task integer,
    task_description character(250)
);
 !   DROP TABLE public.complete_task;
       public         heap    postgres    false            ?            1259    16395    pending_task    TABLE     p   CREATE TABLE public.pending_task (
    id_task integer NOT NULL,
    description_task character varying(250)
);
     DROP TABLE public.pending_task;
       public         heap    postgres    false            ?          0    24576    complete_task 
   TABLE DATA           B   COPY public.complete_task (id_task, task_description) FROM stdin;
    public          postgres    false    210           ?          0    16395    pending_task 
   TABLE DATA           A   COPY public.pending_task (id_task, description_task) FROM stdin;
    public          postgres    false    209   ?       `           2606    16399    pending_task pk_id 
   CONSTRAINT     U   ALTER TABLE ONLY public.pending_task
    ADD CONSTRAINT pk_id PRIMARY KEY (id_task);
 <   ALTER TABLE ONLY public.pending_task DROP CONSTRAINT pk_id;
       public            postgres    false    209            ?   ?   x???;?0Dk?>Ȍ????2?Ȩ?O?r
n?}??E?	ޮV???X??J?l??Z???o??g?7
??Z??UoN~??ω>???Yvr?厧?7?z9
????p&?-?@;b?????+?f@5Ų??ee??[?)0_ ????T      ?   ?   x?%?;?0Dk?)?(??|jR?????qV???Fk'??c???M??J??+?p?9?ᝏ????p?? ?ɨ;???n??b???&RҺ?ha̼?ᓏ}?5?Tu??l^?&m???ɒ??Qm?UТ[mbh?4j???1??Sy??]?f<N ???;N     