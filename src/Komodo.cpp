﻿#include <include/Komodo.h>

int main()
{
    if (!initialize_systems())
    {
        return komodo_exit(1);
    }
    gp_logger->v_add_output("komodo.log");
    gp_logger->v_info("Welcome to Komodo game engine!");

    if (!gp_video_system->v_create_window(640, 480, "Komodo"))
    {
        return komodo_exit(2);
    }
    
    auto shader = gp_shader_manager->add_shader(
        "shaders/openGL/simple/fragment_shader.glsl",
        "shaders/openGL/simple/vertex_shader.glsl"
    );
    if (!shader)
    {
        return komodo_exit(3);
    }
    
    int game_return_code = game_loop();
    return komodo_exit(game_return_code);
}

int game_loop()
{
    bool done = false;
    while (!done)
    {
        gp_video_system->v_update();
        if (gp_video_system->m_closed)
        {
            done = true;
        }
    }
    return 0;
}

bool initialize_systems()
{
    gp_logger = new Logger();
    if (!gp_logger || !gp_logger->m_initialized)
    {
        std::cerr << "Logger failed to initialize!";
        return false;
    }

    gp_config_manager = new JsonConfigManager();
    if (!gp_config_manager || !gp_config_manager->m_initialized)
    {
        std::cerr << "Config Manager failed to initialize!";
        return false;
    }

    gp_input_manager = new OpenGLInputManager();
    if (!gp_input_manager || !gp_input_manager->m_initialized)
    {
        std::cerr << "Input Manager failed to initialize!";
        return false;
    }
    
    gp_audio_system = new AudioSystem();
    if (!gp_audio_system || !gp_audio_system->m_initialized)
    {
        std::cerr << "Audio System failed to initialize!";
        return false;
    }
    
    gp_video_system = new OpenGLVideoSystem();
    if (!gp_video_system || !gp_video_system->m_initialized)
    {
        std::cerr << "Video System failed to initialize!";
        return false;
    }

    gp_shader_manager = new OpenGLShaderManager();
    if (!gp_shader_manager || !gp_shader_manager->m_initialized)
    {
        std::cerr << "Shader Manager failed to initialize!";
        return false;
    }

    return true;
}

int komodo_exit(int exit_code)
{
    shutdown_systems();

    return exit_code;
}

void shutdown_systems()
{
    gp_logger->v_info("Shutting down systems...");

    SAFE_DELETE(gp_shader_manager);
    SAFE_DELETE(gp_video_system);
    SAFE_DELETE(gp_audio_system);
    SAFE_DELETE(gp_input_manager);
    SAFE_DELETE(gp_config_manager);

    SAFE_DELETE(gp_logger);
}